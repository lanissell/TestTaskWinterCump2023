﻿using System;
using Player;

namespace Plates
{
    public class PlateAddingStep: Plate
    {
        public static event Action StepAdding;
        
        public override void ActivatePlateEffect(PlayerStats playerStats)
        {
            StepAdding?.Invoke();
        }
    }
}
