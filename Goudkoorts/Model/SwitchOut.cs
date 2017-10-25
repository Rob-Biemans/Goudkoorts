namespace Goudkoorts
{
    public class SwitchOut : Switch
    {
        private string icon;

        public SwitchOut(string value)
        {
            this.icon = value;
        }

        public override string Icon()
        {
            return this.icon;
        }
    }
}