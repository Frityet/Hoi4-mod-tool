using System;
using System.Collections.Generic;
using System.Linq;

namespace Hoi4ModTool.Common
{
    public static class EnumUtils
    {
        public static Enum[] MembersToArray<TEnum>() where TEnum : Enum => Enum.GetValues(typeof(TEnum)) as Enum[];
    }
}