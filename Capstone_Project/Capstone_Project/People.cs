namespace Capstone_Project
{
    public class People
    {
        #region Enums

        public enum EmotionalState
        {
            ok,
            happy,
            sad,
            angry,
            bored,
            tired
        }

        public enum FavoriteColor
        {
            none,
            white,
            black,
            blue,
            red,
            yellow,
            purple,
            pink,
            green,
            orange,
            cyan
        }
        #endregion

        #region Fields

        private string _name;
        private int _age;
        private EmotionalState _attitude;
        private FavoriteColor _color;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public EmotionalState Attitude
        {
            get { return _attitude; }
            set { _attitude = value; }
        }

        public FavoriteColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        #endregion

        #region Constructors

        public People()
        {


        }

        public People(string name, int age, EmotionalState attitude, FavoriteColor color)
        {
            _name = name;
            _age = age;
            _attitude = attitude;
            _color = color;
        }

        #endregion

        #region Methods

        public string Greeting()
        {
            string greeting;

            switch (_attitude)
            {
                case EmotionalState.ok:
                    greeting = $"Hello, my name is {_name} and I am just ok.";
                    break;

                case EmotionalState.happy:
                    greeting = $"Hello, my name is {_name} and I am having a great day.";
                    break;

                case EmotionalState.sad:
                    greeting = $"Hello, my name is {_name} is feelinf bad.";
                    break;

                case EmotionalState.angry:
                    greeting = $"I'm{_name}, and stay away from me.";
                    break;

                case EmotionalState.bored:
                    greeting = $" I don't know what to do at {_age} years old.";
                    break;

                default:
                    greeting = $"Hello, my name is {_name}.";
                    break;
            }

            return greeting;
        }

        public string FavColor()
        {
            string favcolor;

            switch (_color)
            {
                case FavoriteColor.none:
                    favcolor = $"My name is {_name} and I don't have a favorite color at this time.";
                    break;
                case FavoriteColor.white:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.black:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.blue:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.red:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.yellow:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.purple:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.pink:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.green:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.orange:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                case FavoriteColor.cyan:
                    favcolor = $"My name is {_name} and my favorite color is {_color}";
                    break;
                default:
                    favcolor = $"My name is {_name}";
                    break;
            }
            return favcolor;
        }

        #endregion

    }
}
