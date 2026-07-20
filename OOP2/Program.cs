

namespace OOP2
{
    class Room
    {
        public string roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(string roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine("Room " + roomNumber + " | Type: " + roomType +
                " | Price: OMR " + pricePerNight.ToString("0.00") +
                " | Status: " + status);
        }
    }
    class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;

        // pricePerNight of the booked room, needed for calculateTotalCost().
        // Kept in sync manually whenever the guest is booked (Case 03).
        public double bookedRoomPrice;

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = "Not Assigned";
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
            this.bookedRoomPrice = 0;
        }

        public void displayGuest()
        {
            Console.WriteLine("ID: " + guestId + " | Name: " + guestName +
                " | Room: " + roomNumber +
                " | Check-in: " + checkInDate +
                " | Nights: " + totalNights);
        }

        public double calculateTotalCost()
        {
            return bookedRoomPrice * totalNights;
        }
    }

    internal class Program
        {
            static List<Room> rooms = new List<Room>();
            static List<Guest> guests = new List<Guest>();

            static void Main(string[] args)
            {
                // Pre-load at least 6 rooms of mixed types before the menu starts
                rooms.Add(new Room("101", "Single", 25.00, true));
                rooms.Add(new Room("102", "Single", 25.00, true));
                rooms.Add(new Room("201", "Double", 40.00, true));
                rooms.Add(new Room("202", "Double", 40.00, true));
                rooms.Add(new Room("301", "Suite", 90.00, true));
                rooms.Add(new Room("302", "Suite", 95.00, true));

                bool exitApp = false;

                while (!exitApp)
                {
                    Console.WriteLine("\n================================================");
                    Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                    Console.WriteLine("================================================");
                    Console.WriteLine(" 1. Add New Room");
                    Console.WriteLine(" 2. Register New Guest");
                    Console.WriteLine(" 3. Book a Room for a Guest");
                    Console.WriteLine(" 4. View All Rooms");
                    Console.WriteLine(" 5. View All Guests");
                    Console.WriteLine(" 6. Search & Filter Rooms");
                    Console.WriteLine(" 7. Guest & Booking Statistics");
                    Console.WriteLine(" 8. Update Room Price");
                    Console.WriteLine(" 9. Guest Lookup by Name");
                    Console.WriteLine("10. Room Type Breakdown Report");
                    Console.WriteLine("11. Check Out a Guest");
                    Console.WriteLine("12. Remove Unavailable Rooms");
                    Console.WriteLine("13. Extend Guest Stay");
                    Console.WriteLine("14. Highest Revenue Booking");
                    Console.WriteLine("15. Guest Pagination Viewer");
                    Console.WriteLine(" 0. Exit");
                    Console.WriteLine("================================================");
                    Console.Write("Enter your choice: ");

                    int choice;
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1: AddNewRoom(); break;
                        case 2: RegisterNewGuest(); break;
                        case 3: BookRoomForGuest(); break;
                        case 4: ViewAllRooms(); break;
                        case 5: ViewAllGuests(); break;
                        case 6: SearchAndFilterRooms(); break;
                        case 7: GuestAndBookingStatistics(); break;
                        case 8: UpdateRoomPrice(); break;
                        case 9: GuestLookupByName(); break;
                        case 10: RoomTypeBreakdownReport(); break;
                        case 11: CheckOutGuest(); break;
                        case 12: RemoveUnavailableRooms(); break;
                        case 13: ExtendGuestStay(); break;
                        case 14: HighestRevenueBooking(); break;
                        case 15: GuestPaginationViewer(); break;
                        case 0:
                            exitApp = true;
                            Console.WriteLine("Thank you for using Grand Vista Hotel Management System. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose between 0 and 15.");
                            break;
                    }
                }
            }

            // ===================== EASY CASES (01-05) =====================

            // Case 01 - Add New Room
            static void AddNewRoom()
            {
                Console.Write("Enter room number: ");
                string roomNumber = Console.ReadLine();

                if (rooms.Any(r => r.roomNumber == roomNumber))
                {
                    Console.WriteLine("Error: A room with this number already exists.");
                    return;
                }

                Console.Write("Enter room type (Single/Double/Suite): ");
                string roomType = Console.ReadLine();

                double price;
                try
                {
                    Console.Write("Enter price per night: ");
                    price = double.Parse(Console.ReadLine());

                    if (price <= 0)
                    {
                        Console.WriteLine("Error: Price must be a positive number.");
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid price entered.");
                    return;
                }

                Room newRoom = new Room(roomNumber, roomType, price, true);
                rooms.Add(newRoom);

                Console.WriteLine("Room added successfully!");
                newRoom.displayRoom();
                Console.WriteLine("Total rooms: " + rooms.Count);
            }

            // Case 02 - Register New Guest
            static void RegisterNewGuest()
            {
                Console.Write("Enter guest name: ");
                string name = Console.ReadLine();

                Console.Write("Enter check-in date (e.g. 2026-07-20): ");
                string checkInDate = Console.ReadLine();

                int nights;
                try
                {
                    Console.Write("Enter number of nights: ");
                    nights = int.Parse(Console.ReadLine());

                    if (nights <= 0)
                    {
                        Console.WriteLine("Error: Number of nights must be a positive integer.");
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid number entered.");
                    return;
                }

                string guestId = "G" + (guests.Count() + 1).ToString("000");

                Guest newGuest = new Guest(guestId, name, checkInDate, nights);
                guests.Add(newGuest);

                Console.WriteLine("Guest registered successfully!");
                newGuest.displayGuest();
            }

            // Case 03 - Book a Room for a Guest
            static void BookRoomForGuest()
            {
                Console.Write("Enter guest ID: ");
                string guestId = Console.ReadLine();

                Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
                if (guest == null)
                {
                    Console.WriteLine("Error: Guest not found.");
                    return;
                }

                Console.Write("Enter room number: ");
                string roomNumber = Console.ReadLine();

                Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
                if (room == null)
                {
                    Console.WriteLine("Error: Room not found.");
                    return;
                }

                if (!room.isAvailable)
                {
                    Console.WriteLine("Room is already booked.");
                    return;
                }

                guest.roomNumber = room.roomNumber;
                guest.bookedRoomPrice = room.pricePerNight;
                room.isAvailable = false;

                Console.WriteLine("Booking confirmed!");
                Console.WriteLine("Guest: " + guest.guestName);
                Console.WriteLine("Room: " + room.roomNumber + " (" + room.roomType + ")");
                Console.WriteLine("Price per night: OMR " + room.pricePerNight.ToString("0.00"));
                Console.WriteLine("Total nights: " + guest.totalNights);
                Console.WriteLine("Total cost: OMR " + guest.calculateTotalCost().ToString("0.00"));
            }

            // Case 04 - View All Rooms
            static void ViewAllRooms()
            {
                if (!rooms.Any())
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                var sortedRooms = rooms.OrderBy(r => r.roomNumber).Select(r => r);

                Console.WriteLine("Total rooms: " + rooms.Count());
                foreach (Room room in sortedRooms)
                {
                    room.displayRoom();
                }
            }

            // Case 05 - View All Guests
            static void ViewAllGuests()
            {
                if (!guests.Any())
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                var sortedGuests = guests.OrderBy(g => g.guestName).Select(g => g);

                Console.WriteLine("Total guests: " + guests.Count());
                foreach (Guest guest in sortedGuests)
                {
                    guest.displayGuest();
                }
            }

            // ===================== MEDIUM CASES (06-10) =====================

            // Case 06 - Search & Filter Rooms
            static void SearchAndFilterRooms()
            {
                bool back = false;
                while (!back)
                {
                    Console.WriteLine("\n--- Search & Filter Rooms ---");
                    Console.WriteLine("1. Show all available rooms");
                    Console.WriteLine("2. Filter by room type");
                    Console.WriteLine("3. Filter by max price");
                    Console.WriteLine("4. Room price statistics");
                    Console.WriteLine("0. Back");
                    Console.Write("Enter your choice: ");

                    string subChoice = Console.ReadLine();

                    switch (subChoice)
                    {
                        case "1":
                            var available = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight).ToList();
                            if (!available.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Count: " + available.Count());
                                foreach (Room r in available) r.displayRoom();
                            }
                            break;

                        case "2":
                            Console.Write("Enter room type: ");
                            string type = Console.ReadLine();
                            var byType = rooms.Where(r => r.roomType.ToLower() == type.ToLower()).ToList();
                            if (!byType.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Count: " + byType.Count());
                                foreach (Room r in byType) r.displayRoom();
                            }
                            break;

                        case "3":
                            try
                            {
                                Console.Write("Enter maximum price: ");
                                double maxPrice = double.Parse(Console.ReadLine());
                                var byPrice = rooms.Where(r => r.isAvailable && r.pricePerNight <= maxPrice)
                                                    .OrderBy(r => r.pricePerNight).ToList();
                                if (!byPrice.Any())
                                {
                                    Console.WriteLine("No rooms found for the selected criteria.");
                                }
                                else
                                {
                                    Console.WriteLine("Count: " + byPrice.Count());
                                    foreach (Room r in byPrice) r.displayRoom();
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error: Invalid price entered.");
                            }
                            break;

                        case "4":
                            if (!rooms.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                                break;
                            }
                            int totalRooms = rooms.Count();
                            int availableRooms = rooms.Count(r => r.isAvailable);
                            double avgPrice = rooms.Average(r => r.pricePerNight);
                            double minPrice = rooms.Min(r => r.pricePerNight);
                            double maxP = rooms.Max(r => r.pricePerNight);

                            Console.WriteLine("Total rooms: " + totalRooms);
                            Console.WriteLine("Available rooms: " + availableRooms);
                            Console.WriteLine("Average price: OMR " + avgPrice.ToString("0.00"));
                            Console.WriteLine("Cheapest price: OMR " + minPrice.ToString("0.00"));
                            Console.WriteLine("Most expensive price: OMR " + maxP.ToString("0.00"));
                            break;

                        case "0":
                            back = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }

            // Case 07 - Guest & Booking Statistics
            static void GuestAndBookingStatistics()
            {
                int totalGuests = guests.Count();
                int guestsWithRoom = guests.Count(g => g.roomNumber != "Not Assigned");

                int totalRooms = rooms.Count();
                int bookedRooms = rooms.Count(r => !r.isAvailable);

                Console.WriteLine("Total registered guests: " + totalGuests);
                Console.WriteLine("Guests with a room assigned: " + guestsWithRoom);
                Console.WriteLine("Total rooms: " + totalRooms);
                Console.WriteLine("Booked rooms: " + bookedRooms);

                var activeGuests = guests.Where(g => g.roomNumber != "Not Assigned").ToList();

                if (!activeGuests.Any())
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }

                double avgNights = activeGuests.Average(g => g.totalNights);
                Console.WriteLine("Average nights (active bookings): " + avgNights.ToString("0.00"));

                var topSpenders = activeGuests.OrderByDescending(g => g.calculateTotalCost()).Take(3).ToList();

                Console.WriteLine("\nTop 3 highest-spending guests:");
                foreach (Guest g in topSpenders)
                {
                    Console.WriteLine(g.guestName + " — Room " + g.roomNumber +
                        " — OMR " + g.calculateTotalCost().ToString("0.00"));
                }

                Console.WriteLine("\nBooking summary:");
                var summaryLines = activeGuests.Select(g =>
                    g.guestName + " — Room " + g.roomNumber + " — " + g.totalNights +
                    " nights — OMR " + g.calculateTotalCost().ToString("0.00"));

                foreach (string line in summaryLines)
                {
                    Console.WriteLine(line);
                }
            }

            // Case 08 - Update Room Price
            static void UpdateRoomPrice()
            {
                Console.Write("Enter room number: ");
                string roomNumber = Console.ReadLine();

                Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
                if (room == null)
                {
                    Console.WriteLine("Error: Room not found.");
                    return;
                }

                try
                {
                    Console.Write("Enter new price per night: ");
                    double newPrice = double.Parse(Console.ReadLine());

                    if (newPrice <= 0)
                    {
                        Console.WriteLine("Error: Price must be a positive number. No change made.");
                        return;
                    }

                    double oldPrice = room.pricePerNight;
                    room.pricePerNight = newPrice;

                    Console.WriteLine("Price updated successfully!");
                    Console.WriteLine("Old price: OMR " + oldPrice.ToString("0.00"));
                    Console.WriteLine("New price: OMR " + newPrice.ToString("0.00"));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid price entered. No change made.");
                }
            }

            // Case 09 - Guest Lookup by Name
            static void GuestLookupByName()
            {
                Console.Write("Enter name or partial name to search: ");
                string search = Console.ReadLine();

                var matches = guests.Where(g => g.guestName.ToLower().Contains(search.ToLower())).ToList();

                if (!matches.Any())
                {
                    Console.WriteLine("No guests matched that search.");
                    return;
                }

                Console.WriteLine("Matches found: " + matches.Count());
                foreach (Guest g in matches)
                {
                    Console.WriteLine("ID: " + g.guestId + " | Name: " + g.guestName + " | Room: " + g.roomNumber);
                }
            }

            // Case 10 - Room Type Breakdown Report
            static void RoomTypeBreakdownReport()
            {
                string[] types = { "Single", "Double", "Suite" };

                foreach (string type in types)
                {
                    int count = rooms.Count(r => r.roomType.ToLower() == type.ToLower());
                    Console.WriteLine(type + ": " + count + " room(s)");

                    if (count == 0)
                    {
                        Console.WriteLine(type + " average price: N/A");
                    }
                    else
                    {
                        double avg = rooms.Where(r => r.roomType.ToLower() == type.ToLower()).Average(r => r.pricePerNight);
                        Console.WriteLine(type + " average price: OMR " + avg.ToString("0.00"));
                    }
                }

                if (rooms.Any())
                {
                    double overallAvg = rooms.Average(r => r.pricePerNight);
                    Console.WriteLine("\nOverall average price: OMR " + overallAvg.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("\nOverall average price: N/A");
                }
            }

            // ===================== ADVANCED CASES (11-15) =====================

            // Case 11 - Check Out a Guest
            static void CheckOutGuest()
            {
                Console.Write("Enter guest ID: ");
                string guestId = Console.ReadLine();

                Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
                if (guest == null)
                {
                    Console.WriteLine("Error: Guest not found.");
                    return;
                }

                if (guest.roomNumber == "Not Assigned")
                {
                    Console.WriteLine("This guest has no active booking.");
                    return;
                }

                Room room = rooms.FirstOrDefault(r => r.roomNumber == guest.roomNumber);

                Console.WriteLine("\n--- Final Bill ---");
                Console.WriteLine("Guest: " + guest.guestName);
                Console.WriteLine("Room: " + guest.roomNumber + (room != null ? " (" + room.roomType + ")" : ""));
                Console.WriteLine("Check-in: " + guest.checkInDate);
                Console.WriteLine("Total nights: " + guest.totalNights);
                Console.WriteLine("Price per night: OMR " + guest.bookedRoomPrice.ToString("0.00"));
                Console.WriteLine("Total cost: OMR " + guest.calculateTotalCost().ToString("0.00"));

                Console.Write("\nConfirm checkout? (Y/N): ");
                string confirm = Console.ReadLine();

                if (confirm.ToUpper() != "Y")
                {
                    Console.WriteLine("Checkout cancelled. No changes made.");
                    return;
                }

                if (room != null)
                {
                    room.isAvailable = true;
                }

                guests.Remove(guest);

                Console.WriteLine("Checkout complete!");
                Console.WriteLine("Total guests remaining: " + guests.Count());
                Console.WriteLine("Total rooms: " + rooms.Count());

                if (room != null)
                {
                    bool isNowAvailable = rooms.Any(r => r.roomNumber == room.roomNumber && r.isAvailable);
                    Console.WriteLine("Room " + room.roomNumber + " is now available: " + isNowAvailable);
                }
            }

            // Case 12 - Remove Unavailable Rooms
            static void RemoveUnavailableRooms()
            {
                var removable = rooms.Where(r => !r.isAvailable &&
                                             !guests.Any(g => g.roomNumber == r.roomNumber))
                                      .OrderBy(r => r.roomNumber)
                                      .ToList();

                if (!removable.Any())
                {
                    Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                    return;
                }

                Console.WriteLine("Rooms safe to remove:");
                foreach (Room r in removable)
                {
                    Console.WriteLine(r.roomNumber + " | " + r.roomType + " | OMR " + r.pricePerNight.ToString("0.00"));
                }

                Console.WriteLine("Count: " + removable.Count());
                Console.Write("Confirm removal? (Y/N): ");
                string confirm = Console.ReadLine();

                if (confirm.ToUpper() != "Y")
                {
                    Console.WriteLine("Removal cancelled. No rooms removed.");
                    return;
                }

                rooms.RemoveAll(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber));

                Console.WriteLine("Rooms removed successfully!");
                Console.WriteLine("Updated total room count: " + rooms.Count());

                var remaining = rooms.Select(r => r.roomNumber + " (" + r.roomType + ")");
                Console.WriteLine("Remaining rooms:");
                foreach (string r in remaining)
                {
                    Console.WriteLine(r);
                }
            }

            // Case 13 - Extend Guest Stay
            static void ExtendGuestStay()
            {
                Console.Write("Enter guest ID: ");
                string guestId = Console.ReadLine();

                Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
                if (guest == null)
                {
                    Console.WriteLine("Error: Guest not found.");
                    return;
                }

                if (guest.roomNumber == "Not Assigned")
                {
                    Console.WriteLine("This guest has no active booking to extend.");
                    return;
                }

                try
                {
                    Console.Write("Enter number of additional nights: ");
                    int extraNights = int.Parse(Console.ReadLine());

                    if (extraNights <= 0)
                    {
                        Console.WriteLine("Error: Additional nights must be a positive integer. No change made.");
                        return;
                    }

                    guest.totalNights += extraNights;

                    Console.WriteLine("Stay extended successfully!");
                    Console.WriteLine("Updated total nights: " + guest.totalNights);
                    Console.WriteLine("New total cost: OMR " + guest.calculateTotalCost().ToString("0.00"));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid number entered. No change made.");
                }
            }

            // Case 14 - Highest Revenue Booking
            static void HighestRevenueBooking()
            {
                var activeGuests = guests.Where(g => g.roomNumber != "Not Assigned").ToList();

                if (!activeGuests.Any())
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }

                var projected = activeGuests.Select(g => new
                {
                    Name = g.guestName,
                    Room = g.roomNumber,
                    Cost = g.calculateTotalCost()
                });

                var topEarner = projected.OrderByDescending(g => g.Cost).Take(1).First();

                Console.WriteLine("Top earner:");
                Console.WriteLine("Guest: " + topEarner.Name);
                Console.WriteLine("Room: " + topEarner.Room);
                Console.WriteLine("Total cost: OMR " + topEarner.Cost.ToString("0.00"));
            }

            // Case 15 - Guest Pagination Viewer
            static void GuestPaginationViewer()
            {
                const int pageSize = 3;

                if (!guests.Any())
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                int totalPages = (int)Math.Ceiling(guests.Count() / (double)pageSize);

                int pageNumber;
                try
                {
                    Console.Write("Enter page number (1 to " + totalPages + "): ");
                    pageNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid page number entered.");
                    return;
                }

                if (pageNumber < 1 || pageNumber > totalPages)
                {
                    Console.WriteLine("That page does not exist.");
                    return;
                }

                var pageGuests = guests.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                Console.WriteLine("\nPage " + pageNumber + " of " + totalPages + ":");
                foreach (Guest g in pageGuests)
                {
                    g.displayGuest();
                }
            }
        }
    }
