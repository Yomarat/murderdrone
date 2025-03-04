using System;
namespace MURDERDRONE
{
    public class ModConfig
    {
        public bool Active { get; set; }
        public string KeyboardShortcut { get; set; }
        public int RotationSpeed { get; set; }
        public int Damage { get; set; }
        public int ProjectileVelocity { get; set; }

        public ModConfig()
        {
            this.Active = true;
            this.KeyboardShortcut = "F";
            this.RotationSpeed = 10;
            this.Damage = -100;
            this.ProjectileVelocity = 30;
        }
    }
}
