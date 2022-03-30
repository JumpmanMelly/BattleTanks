using Godot;
using Godot.Collections;

namespace BattleTanks.TankParts
{
public class Test : Spatial
{
    [Export]
    public float Speed = 50f;
    private float _time = 0f;
    private float _offset = 0.86f;

    private Array links;

    public override void _Ready()
    {
        links = GetNode<Path>("Path").GetChildren();
    }
    public override void _Process(float delta)
    {
        _time += delta;
        int count =0;
        foreach (PathFollow index in links)
        {
            index.Offset = Speed * _time + (_offset * count);
            count += 1;
        }
    }
}
}
