﻿using System;
using UnityEngine;

namespace ShaderWizard {
    internal static class Utils {

        public static Rect AnchorLeft(Rect parent, float offset, float width) {
            return new Rect(parent.x + offset, parent.y, width, parent.height);
        }

        public static Rect AnchorRight(Rect parent, float offset, float width) {
            return new Rect(parent.x + parent.width - width - offset, parent.y, width, parent.height);
        }

        public static Rect Anchor(Rect parent, float leftOffset, float rightOffset) {
            return new Rect(parent.x + leftOffset, parent.y, parent.width - leftOffset - rightOffset, parent.height);
        }

        public static Rect ShareRect(Rect parent, int length, int index) {
            return new Rect(parent.x + (parent.width / length) * index, parent.y, parent.width / length, parent.height);
        }

        public static Rect DivideRect(Rect parent, int index, float divideAt) {
            return  new Rect(parent.x + parent.width * divideAt * index,parent.y, parent.width * Math.Abs(index - divideAt), parent.height);
        }
    }
}