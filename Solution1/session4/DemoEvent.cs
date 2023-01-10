namespace Solution.session4;

public class DemoEvent
{
    public event PrintString Action;

    public DemoEvent(PrintString fuctionName)
    {
        Action += fuctionName;
    }
}
    }

    public void ClickAction()
    {
        Action("Click Here");
    }
}