using Godot;
using Godot.Collections;

namespace BattleTanks.TankParts
{
    public class Test : Spatial
    {
        [Export]
        public float Speed = 20f;

        [Export]
        public float Offset = 0.7f;

        [Export]
        public int Tracks = 25;

        private Array _links;
        private float _time = 0f;

        public override void _Ready()
        {
            for (int i = 1; i <= Tracks; i += 1)
            {
                var newLink = MakeLink();
                GetNode<Path>("Path").AddChild(newLink);
            }

            _links = GetNode<Path>("Path").GetChildren();
        }
        public override void _Process(float delta)
        {
            _time += delta;
            int count = 0;
            foreach (PathFollow index in _links)
            {
                index.Offset = Speed * _time + (Offset * count);
                count += 1;
            }
        }

        private PathFollow MakeLink()
        {
            PathFollow linkPath = new PathFollow();
            linkPath.RotationMode = PathFollow.RotationModeEnum.Oriented;

            PackedScene linkPs = GD.Load<PackedScene>("res://objects/Tank Parts/Link.tscn");
            var link = linkPs.Instance();
            linkPath.AddChild(link);
            
            return linkPath;
        }
    }
}
