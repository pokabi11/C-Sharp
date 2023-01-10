namespace Solution1.session4;

public class DemoEvent
{
    public class Button
    {
        public event PrintString Action;

        public Button(PrintString functionName)
        {
            Action += functionName;
        }

        public void ClickAction()
        {
            Action("Click here");
        }
    }
}