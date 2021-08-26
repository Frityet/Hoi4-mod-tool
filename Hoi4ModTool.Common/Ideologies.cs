using System;
using System.Collections.Generic;

namespace Hoi4ModTool.Common
{
    /// <remarks>
    /// 
    /// What is this, you may ask?
    ///
    /// Well, I wanted to split the ideologies into multiple enums
    /// so that it would be neater, but I would also like to have
    /// a dictionary mapping the enum names to the actual HOI4 names,
    /// so what my "genius" ass did was assign every enum entry an int
    /// that ascends from 1936 (you see what I did there?)
    ///
    /// Range 1936-1938 is Democracy,
    /// Range 1939-1942 is Fascism,
    /// Range 1943-1945 is Communism,
    /// Range 1946-1949 is Non-Aligned
    ///
    /// Because all an enum is a named int, we can use it in place aswell,
    /// letting the dictionary work
    ///
    /// - Frityet, 26/8/21, 00:15
    ///
    ///
    /// Update (00:31): turns out you can just use the `Enum` class
    /// </remarks>
    public static class Ideologies
    {
        #region Ideologies

        public enum Democracy
        {
            Conservatism =  1936,
            Liberalism =    1937,
            Socialism =     1938,
        }
        
        public enum Fascism
        {
            Nazism =    1939,
            Fascism =   1940,
            Falangism = 1941,
            Rexism =    1942,
        }
        
        public enum Communism
        {
            Marxism =   1943,
            Leninism =  1944,
            Stalinism = 1945,
        }
        
        public enum NonAligned
        {
            Despotism =     1946,
            Oligarchism =   1947,
            Moderatism =    1948,
            Centrism =      1949,
        }

        

        public static readonly Dictionary<Enum, string> IDEOLOGY_NAMES = new Dictionary<Enum, string>()
        {
            { Democracy.Conservatism, "democratic-conservatism" },
            { Democracy.Liberalism, "democratic-liberalism" },
            { Democracy.Socialism, "democratic-socialism" },
            
            { Fascism.Nazism, "fascism-nazism" },
            { Fascism.Fascism, "fascism-fascism" },
            { Fascism.Falangism, "fascism-falangism" },
            { Fascism.Rexism, "fascism-rexism" },
            
            { Communism.Marxism, "communism-marxism" },
            { Communism.Leninism, "communism-leninism" },
            { Communism.Stalinism, "communism-Stalinism" },
            
            { NonAligned.Despotism, "non aligned-despotism" },
            { NonAligned.Oligarchism, "non aligned-oligarchism" },
            { NonAligned.Moderatism, "non aligned-moderatism" },
            { NonAligned.Centrism, "non aligned-centrism" },
        };
        #endregion
        
        public enum Parties
        {
            Fascism,
            Communism,
            Democracy,
            NonAligned
        }

        public static readonly Dictionary<Parties, Enum[]> PARTY_IDEOLOGIES = new Dictionary<Parties, Enum[]>()
        {
            { Parties.Fascism, EnumUtils.MembersToArray<Fascism>() },
            { Parties.Communism, EnumUtils.MembersToArray<Communism>() },
            { Parties.Democracy, EnumUtils.MembersToArray<Democracy>() },
            { Parties.NonAligned, EnumUtils.MembersToArray<NonAligned>() }
        };
    }
}