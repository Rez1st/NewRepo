namespace ConsoleApp2.SeaBattle
{
    internal class GameSet
    {
        private int _anyField; // тут хранится значение которое правильно прошло через set;
        public int AnyField
        {
            get
            {
                // тут может быть логика получения
                return _anyField;
            }
            set
            {
                // тут может быть логика валидации или сохранения
                _anyField = value;
            }
        }


        private static int xs = 4;
        private static int s = 3;
        private static int m = 2;
        private static int l = 1;

        public static bool[,] GetNewField()
        {
            return new[,] {{true, false}, {false, true}};
        }
    }
}