﻿namespace model{
    public interface ICompareConfig {
        CompareMethod RoutinesCompareMethod { get; }
        CompareMethod TablesCompareMethod { get; }
        CompareMethod ColumnsCompareMethod { get; }
        CompareMethod ForeignKeysCompareMethod { get; }

        bool IgnoreProps { get; }
        bool IgnoreDefaultsNameMismatch { get; }
    }

    public enum CompareMethod {
        Ignore, FindAllDifferences, FindButIgnoreAdditionalItems
    }
}