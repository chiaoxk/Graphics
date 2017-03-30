using RMGUI.GraphView;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UnityEditor.VFX.UI
{
    class VFXParameterPresenter : VFXNodePresenter, IVFXPresenter
    {
        protected override NodeAnchorPresenter CreateAnchorPresenter(VFXSlot slot, Direction direction)
        {
            var anchor = base.CreateAnchorPresenter(slot, direction);
            anchor.anchorType = slot.property.type;
            anchor.name = slot.property.type.Name;
            return anchor;
        }
    }
}
