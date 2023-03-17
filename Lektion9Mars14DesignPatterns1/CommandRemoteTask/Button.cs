namespace Lektion9Mars14DesignPatterns1.CommandRemoteTask
{
    public class Button
    {
        IButtonCommand command;

        private int something;
        public int Something { 
            get
            {
                return something;
            } 
            set
            {
                something = value;
                command.ExecuteButtonCommand();
            }
        }

        public Button(IButtonCommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.ExecuteButtonCommand();
        }
    }
}