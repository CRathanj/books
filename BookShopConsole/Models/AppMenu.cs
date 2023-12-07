using System.Runtime.CompilerServices;

namespace BookShopConsole.Models
{
    public class AppMenu
    {
        public string Title { get; set; } = "";

        public string ChosenText { get; set; } = "Index";
        public string LeadingText { get; set; } = "  ";
        public List<MenuItem> Menus { get; set; } = [];

        public bool LoopBreak { get; set; } = false;

        public void Show()
        {
            Console.WriteLine("[" + Title + " Menu]");
            for (int index = 0; index < Menus.Count; ++index)
            {
                MenuItem menu = Menus[index];
                DefaultInterpolatedStringHandler interpolatedStringHandler = new(1, 2);
                interpolatedStringHandler.AppendFormatted<int>(index + 1, 3);
                interpolatedStringHandler.AppendLiteral("-");
                interpolatedStringHandler.AppendFormatted(menu.Text);
                Console.WriteLine(interpolatedStringHandler.ToStringAndClear());
            }
        }

        public MenuItem GetMenu() => Menus[AppMenu.Input(1, Menus.Count, ChosenText, LeadingText) - 1];

        public void MenuSimulate(Action? leadingAction = null)
        {
            LoopBreak = false;
            while (!LoopBreak)
            {
                leadingAction?.Invoke();
                Show();
                GetMenu().Action();
                Console.ReadLine();
            }
        }

        public static int Input(int lower, int upper, string text, string leading = "")
        {
            int result;
            while (true)
            {
                DefaultInterpolatedStringHandler interpolatedStringHandler = new(5, 4);
                interpolatedStringHandler.AppendFormatted(leading);
                interpolatedStringHandler.AppendFormatted(text);
                interpolatedStringHandler.AppendLiteral("(");
                interpolatedStringHandler.AppendFormatted<int>(lower);
                interpolatedStringHandler.AppendLiteral("-");
                interpolatedStringHandler.AppendFormatted<int>(upper);
                interpolatedStringHandler.AppendLiteral("): ");
                Console.Write(interpolatedStringHandler.ToStringAndClear());

                if (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine(leading + ">Invalid input format");
                }
                else if (lower > result || result > upper)
                {
                    interpolatedStringHandler = new (41, 4);
                    interpolatedStringHandler.AppendFormatted(leading);
                    interpolatedStringHandler.AppendLiteral(">The input is ");
                    interpolatedStringHandler.AppendFormatted<int>(result);
                    interpolatedStringHandler.AppendLiteral(", the input must be in [");
                    interpolatedStringHandler.AppendFormatted<int>(lower);
                    interpolatedStringHandler.AppendLiteral(", ");
                    interpolatedStringHandler.AppendFormatted<int>(upper);
                    interpolatedStringHandler.AppendLiteral("]");
                    Console.WriteLine(interpolatedStringHandler.ToStringAndClear());
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}