
#region Using
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace SpaceShooter
{
    public class WeaponTorpedoMk2 : Weapon
    {
        public WeaponTorpedoMk2()
        {
            boltRange = 11f;            
            refireTime = 6000;
            muzzleOffset = Vector2.Zero;
            muzzleVariation = Vector2.Zero;
            
            prjData = ProjectileTypes.PrjTorpedo;

            /*
            minDeviation = -0.05f;
            maxDeviation = 0.05f;
            minDeviationTime = 300;
            maxDeviationTime = 800;
            */


            base.Initialize();
        }
    }
}