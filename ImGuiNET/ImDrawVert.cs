﻿using System.Numerics;
using JetBrains.Annotations;

// ReSharper disable IdentifierTypo

namespace imgui.NET;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public struct ImDrawVert
{
    public Vector2 Pos;

    public Vector2 Uv;

    public uint Col;

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{nameof(Pos)}: {Pos:F5}, {nameof(Uv)}: {Uv:F5}, {nameof(Col)}: 0x{Col:X8}";
    }
}