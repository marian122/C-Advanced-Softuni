using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, Dictionary<string, string>>();

            while (input[0] != "Output")
            {
                var departmentRoom = input[0];
                var doctor = input[1] + ' ' + input[2];
                var patient = input[3];

                if (!dict.ContainsKey(departmentRoom))
                {
                    dict.Add(departmentRoom, new Dictionary<string, string>());
                }
                if (dict[departmentRoom].Count <= 60)
                {
                    dict[departmentRoom].Add(patient, doctor);
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

                var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {


                if (command.Length == 1)
                {
                    foreach (var department in dict.Where(x => x.Key == command[0]))
                    {
                        foreach (var patientAndDoctor in department.Value)
                        {
                            Console.WriteLine(patientAndDoctor.Key);
                            
                        }
                    }
                    
                }

                else if (char.IsDigit(command[1][0]))
                {
                    var roomCounter = 0;
                    var department = command[0];
                    var room = int.Parse(command[1]);

                    var patientlist = new List<string>();
                    foreach (var doctorAndPatient in dict.OrderByDescending(x => x.Key).ThenBy(x => x.Value).Where(x => x.Key == command[0]))
                    {
                        foreach (var patientAndDoctor in doctorAndPatient.Value)
                        {
                            roomCounter++;
                            if (roomCounter > (room - 1) * 3 && roomCounter <= (room - 1) * 3 + 3)
                            {
                                patientlist.Add(patientAndDoctor.Key);

                            }
                        }
                        
                    }

                    patientlist.Sort();

                    foreach (var patient in patientlist)
                    {
                        Console.WriteLine(patient);
                    }
                    
                }

                else
                {
                    var doctor = command[0] + " " + command[1];

                    var patientlist = new List<string>();
                    foreach (var doctorAndPatient in dict)
                    {
                        foreach (var patientAndDoctor in doctorAndPatient.Value.Where(x => x.Value == doctor))
                        {
                            patientlist.Add(patientAndDoctor.Key);
                        }
                    }

                    patientlist.Sort();

                    foreach (var doct in patientlist)
                    {
                        Console.WriteLine(doct);
                    }
                    
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
