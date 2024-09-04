namespace Game.Protocol.Communication
{
    using System;

    /// <summary>
    /// MemberTypeConverter
    /// </summary>
    public static class MemberTypeConverter
    {
        /// <summary>
        /// MemberType Switch PlatformMemberType
        /// </summary>
        /// <param name="memberType"></param>
        /// <returns></returns>
        public static PlatformMemberType ToPlatformMemberType(this MemberType memberType)
        {
            try
            {
                return (PlatformMemberType)((int)memberType);
            }
            catch
            {
                throw new ArgumentException("The input enum value unable convert to specific enum number");
            }
        }

        /// <summary>
        /// PlatformMemberType Switch MemberType
        /// </summary>
        /// <param name="platformMemberType"></param>
        /// <returns></returns>
        public static MemberType ToMemberType(this PlatformMemberType platformMemberType)
        {
            try
            {
                return (MemberType)((int)platformMemberType);
            }
            catch
            {
                throw new ArgumentException("The input enum value unable convert to specific enum number");
            }
        }
    }
}
