using UnityEngine;

public class GameManager : SingletonMonobehavior<GameManager>
{
    [SerializeField] private string foobar;

    private string _name = "foo";
    public string Name => _name;

    private string _description = "bar";
    public string Description => _description;

    private long ticks;
    public long CurrentTick => ticks;

    public string GetStatus()
    {
        return "I am running!";
    }

    private void Update()
    {
        ticks++;
    }
}
