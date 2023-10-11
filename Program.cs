namespace File_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList FileList = new DLList();
            StreamReader reader;
            int totalCharCount = 0;
            char ch;

            string file = @"C:\tmp\cstext.txt";
            Node node;

            try
            {
                reader = new StreamReader(file);

                while(reader.Peek() >= 0 )
                {
                    ch = (char)reader.Read();
                    if ((Convert.ToInt32(ch) == 13) || (Convert.ToInt32(ch) == 10))
                    {
                        reader.Read();
                        continue;
                    }

                    node = FileList.GetNodePosition(ch);
                    if (node != null)
                    {
                        FileList.IncreaseCount(node);
                    }else
                    {
                        FileList.InsertLast(ch);
                    }

                    totalCharCount++;
                }
                reader.Close();

                Console.WriteLine("Traverse...");
                Console.WriteLine($"TotalChars: {totalCharCount}");
                FileList.Traverse(totalCharCount);





            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }catch(IOException  e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}