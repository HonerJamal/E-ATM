# E-ATM



 var persons = connection.Query<Person>("SELECT id, name, email, phone FROM persons;").ToList();
            foreach(Person p in persons)
            {
                Console.WriteLine(p.id + "  " + p.name + " " + p.email + " " + p.phone);