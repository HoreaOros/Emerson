using System;


namespace HelloWorld_v2
{
    class World
    {
        private string id;

        // metoda constructor are intotdeauna acelasi nume ca si clasa din care face parte
        public World(string id) 
        {
            this.id = id;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello I am {0}", id);
        }

        public void SayHello(string v)
        {
            //Console.WriteLine("{0}, {1}", v, id);

            string line;

            line = v + ", " + id;

            Console.WriteLine(line);
        }
    }
}
