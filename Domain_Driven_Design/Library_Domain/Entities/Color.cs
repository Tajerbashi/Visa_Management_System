namespace Domain_Driven_Design_Solution.Library_Domain.Entities
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Color Mix(Color color) => new Color
            (
                Red + color.Red,
                Green + color.Green,
                Blue + color.Blue
            );

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            var model = obj as Color;
            if (model == null) return false;
            return
                    model.Red == Red
                && model.Green == Green
                && model.Blue == Blue;
        }

        public static bool operator ==(Color left, Color right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Equals(right);

        }
        public static bool operator !=(Color left, Color right)
        {
            return !(left == right);
        }
    }
}
