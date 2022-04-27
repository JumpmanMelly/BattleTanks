using Godot;
using System;

namespace BattleTanks.TankParts 
{

    public class Tank : VehicleBody
    {
        [Export]
        float HorsePower = 200.0f;
        private float accel_speed = 20.0f;

        private Vector2 _velocity = Vector2.Zero;
        private float _steerAngle = Mathf.Deg2Rad(30);
        private float steer_speed = 3;
        private float brake_power = 40;
        private float brake_speed = 40;

        public override void _PhysicsProcess(float delta) {
            //throttle
            var throt_input = Input.GetActionStrength("forward") - Input.GetActionStrength("back");
            EngineForce = Mathf.Lerp(EngineForce, throt_input*HorsePower, accel_speed*delta);

            //steering
            var steer_input = Input.GetActionStrength("right") - Input.GetActionStrength("left");
            Steering = Mathf.LerpAngle(Steering, steer_input * _steerAngle, steer_speed * delta);

            //braking
            var brake_input = Input.GetActionStrength("brake");
            Brake = Mathf.Lerp(Brake, brake_input*brake_power,brake_speed*delta);
        }
    }
}

