// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Input.Bindings;

namespace osu.Game.Rulesets.Mania
{
    public class SingleStageVariantGenerator
    {
        private readonly int variant;
        private readonly InputKey[] leftKeys;
        private readonly InputKey[] rightKeys;

        public SingleStageVariantGenerator(int variant)
        {
            this.variant = variant;

            // 10K is special because it expands towards the centre of the keyboard (V/N), rather than towards the edges of the keyboard.
            if (variant == 10)
            {
                leftKeys = new[] { InputKey.A, InputKey.S, InputKey.D, InputKey.F, InputKey.V };
                rightKeys = new[] { InputKey.N, InputKey.J, InputKey.K, InputKey.L, InputKey.Semicolon };
            }
            else
            {
                leftKeys = new[] { InputKey.Q, InputKey.A, InputKey.Z, InputKey.W, InputKey.S, InputKey.X, InputKey.E, InputKey.D, InputKey.C, InputKey.R, InputKey.F, InputKey.V, InputKey.T };
                rightKeys = new[] { InputKey.G, InputKey.B, InputKey.Y, InputKey.H, InputKey.N, InputKey.U, InputKey.J, InputKey.M, InputKey.I, InputKey.K, InputKey.O, InputKey.L, InputKey.P };
            }
        }

        public IEnumerable<KeyBinding> GenerateMappings() => new VariantMappingGenerator
        {
            LeftKeys = leftKeys,
            RightKeys = rightKeys,
            SpecialKey = InputKey.Space,
            SpecialAction = ManiaAction.Special1,
            NormalActionStart = ManiaAction.Key1,
        }.GenerateKeyBindingsFor(variant, out _);
    }
}
