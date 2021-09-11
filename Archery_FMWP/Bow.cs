

public class Bow
{
    private Arrow loadedArrow;

    public void Load(Arrow arrow)
    {
        loadedArrow = arrow;
    }

    public Arrow Shoot()
    {
        var arrow = loadedArrow;
        loadedArrow = null;
        return arrow;
    }
}

