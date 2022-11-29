﻿using JetBrains.Annotations;

namespace imgui.NET;

/// <summary>
///     https://github.com/ocornut/imgui/blob/9aae45eb4a05a5a1f96be1ef37eb503a12ceb889/imgui.h#L1897
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
partial class ImGuiKeyData
{
    /// <inheritdoc />
    public override string ToString()
    {
        return $"{nameof(Down)}: {Down}, {nameof(DownDuration)}: {DownDuration}, {nameof(DownDurationPrev)}: {DownDurationPrev}, {nameof(AnalogValue)}: {AnalogValue}";
    }
}