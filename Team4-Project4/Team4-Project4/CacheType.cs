///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Team4_Project4/Team4_Project4
//	File Name:         CacheType.cs
//	Description:       CacheType enum file for determining cache set associativity
//	Course:            CSCI-4717-201 - Comp Architecture
//	Authors:           Zachary Lykins, lykinsz@etsu.edu            
//	                   Bobby Mullins, mullinsbd@etsu.edu
//	                   Christopher Poteet, poteetc1@etsu.edu
//	                   William Simmons, simmonswa@etsu.edu
//                     Isaiah Jayne, jaynei@etsu.edu
//	Created:           Monday, April  18, 2022
//	Copyright:         Team 4
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Team4_Project4
{
    /// <summary>
    /// CacheType enum for use by cache config
    /// </summary>
    public enum CacheType
    {
        TWOWAY,   //2-Way Set Associative
        FOURWAY   //4-Way Set Associative

    }//end CacheType enum

}//end Team4_Project4 namespace
