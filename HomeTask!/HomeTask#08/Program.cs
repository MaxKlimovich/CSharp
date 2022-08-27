 byte num = 1;
            while (num <= 40)
            {
                int result = num % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + num);
                    num++;
                }
                else
                {
                    num++;
                }
            }