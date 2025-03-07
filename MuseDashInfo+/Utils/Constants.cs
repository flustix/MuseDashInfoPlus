﻿namespace MDIP.Utils;

public static class Constants
{
    public const string TEXT_ALL_PERFECT = "AP";
    public const string TEXT_TRUE_PERFECT = "TP";

    public const string TEXT_DIFF_1 = "Easy";
    public const string TEXT_DIFF_2 = "Hard";
    public const string TEXT_DIFF_3 = "Master";
    public const string TEXT_DIFF_4 = "Hidden";
    public const string TEXT_DIFF_5 = "Special";

    public const string COLOR_GAP_BEHIND = "#9338fb";
    public const string COLOR_GAP_AHEAD = "#fe41f3";

    public const string COLOR_EARLY_COUNT = "#38bfee";
    public const string COLOR_LATE_COUNT = "#ff089f";

    public const string COLOR_RANK_TP = "#ff0050";
    public const string COLOR_RANK_AP = "#fff000";
    public const string COLOR_RANK_SS = "#ccf0fe";
    public const string COLOR_RANK_S = "#ff0089";
    public const string COLOR_RANK_A = "#ad00ff";
    public const string COLOR_RANK_B = "#00bbff";
    public const string COLOR_RANK_C = "#00ff23";
    public const string COLOR_RANK_D = "#a2a2a2";

    public const string COLOR_WHITE = "#fdfdfa";

    public const float SCORE_ZOOM_OUT_Y = 670f;
    public const float SCORE_ZOOM_IN_Y = 530f;

    public static Vector3 POS_LOWER_LEFT_TEXT { get; private set; } = new(-866, -460, 0);
    public static Vector3 POS_LOWER_RIGHT_TEXT { get; private set; } = new(850, -460, 0);
    public static Vector3 POS_SCORE_BELOW_TEXT { get; private set; } = new(0, -135, 0);
    public static Vector3 POS_SCORE_RIGHT_TEXT { get; private set; } = new(55, -64, 0);
    public static Vector3 POS_UPPER_LEFT_TEXT { get; private set; } = new(-850, 310, 0);
    public static Vector3 POS_UPPER_RIGHT_TEXT { get; private set; } = new(720, 470, 0);

    public static Dictionary<ScoreStyleType, Vector2> OFFSET_SCORE_BELOW_TEXT { get; private set; } = new()
    {
        { ScoreStyleType.GC, new(325, 0) },
        { ScoreStyleType.Djmax, new(260, 0) },
        { ScoreStyleType.ArkNight, new(55, -160) },
        { ScoreStyleType.OtherEN, new(270, 0) },
        { ScoreStyleType.OtherCN, new(160, 0) },
        { ScoreStyleType.Unknown, new(260, 0) }
    };

    public static Dictionary<ScoreStyleType, float> OFFSET_SCORE_RIGHT_TEXT { get; private set; } = new()
    {
        { ScoreStyleType.GC, -55 },
        { ScoreStyleType.Djmax, -78 },
        { ScoreStyleType.ArkNight, -60 },
        { ScoreStyleType.OtherEN, -64 },
        { ScoreStyleType.OtherCN, -64 },
        { ScoreStyleType.Unknown, -64 }
    };
}