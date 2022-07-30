// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System.ComponentModel;
using osu.Framework.Allocation;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Mania
{
    [Cached] // Used for touch input, see ColumnTouchInputArea.
    public class ManiaInputManager : RulesetInputManager<ManiaAction>
    {
        public ManiaInputManager(RulesetInfo ruleset, int variant)
            : base(ruleset, variant, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum ManiaAction
    {
        [Description("Special 1")]
        Special1 = 1,

        [Description("Special 2")]
        Special2,

        // This offsets the start value of normal keys in-case we add more special keys
        // above at a later time, without breaking replays/configs.
        [Description("Key 1")]
        Key1 = 10,

        [Description("Key 2")]
        Key2,

        [Description("Key 3")]
        Key3,

        [Description("Key 4")]
        Key4,

        [Description("Key 5")]
        Key5,

        [Description("Key 6")]
        Key6,

        [Description("Key 7")]
        Key7,

        [Description("Key 8")]
        Key8,

        [Description("Key 9")]
        Key9,

        [Description("Key 10")]
        Key10,

        [Description("Key 11")]
        Key11,

        [Description("Key 12")]
        Key12,

        [Description("Key 13")]
        Key13,

        [Description("Key 14")]
        Key14,

        [Description("Key 15")]
        Key15,

        [Description("Key 16")]
        Key16,

        [Description("Key 17")]
        Key17,

        [Description("Key 18")]
        Key18,

        [Description("Key 19")]
        Key19,

        [Description("Key 20")]
        Key20,

        [Description("Key 21")]
        Key21,

        [Description("Key 22")]
        Key22,

        [Description("Key 23")]
        Key23,

        [Description("Key 24")]
        Key24,

        [Description("Key 25")]
        Key25,

        [Description("Key 26")]
        Key26,

        [Description("Key 27")]
        Key27,

        [Description("Key 28")]
        Key28,

        [Description("Key 29")]
        Key29,

        [Description("Key 30")]
        Key30,

        [Description("Key 31")]
        Key31,

        [Description("Key 32")]
        Key32,

        [Description("Key 33")]
        Key33,

        [Description("Key 34")]
        Key34,

        [Description("Key 35")]
        Key35,

        [Description("Key 36")]
        Key36,

        [Description("Key 37")]
        Key37,

        [Description("Key 38")]
        Key38,

        [Description("Key 39")]
        Key39,

        [Description("Key 40")]
        Key40,

        [Description("Key 41")]
        Key41,

        [Description("Key 42")]
        Key42,

        [Description("Key 43")]
        Key43,

        [Description("Key 44")]
        Key44,

        [Description("Key 45")]
        Key45,

        [Description("Key 46")]
        Key46,

        [Description("Key 47")]
        Key47,

        [Description("Key 48")]
        Key48,

        [Description("Key 49")]
        Key49,

        [Description("Key 50")]
        Key50,

        [Description("Key 51")]
        Key51,

        [Description("Key 52")]
        Key52,
    }
}
