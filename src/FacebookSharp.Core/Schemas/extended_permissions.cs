using System;

namespace FacebookSharp.Schemas
{
    /// <summary>
    /// Extended permissions for faecbook.
    /// </summary>
    /// <remarks>
    /// http://developers.facebook.com/docs/authentication/permissions
    /// </remarks>
    [Flags]
    public enum extended_permissions : long
    {
        None = 1,
        All = 2,

        #region Publishing Permissions
        publish_stream = 4,
        create_event = 8,
        rsvp_event = 16,
        sms = 32,
        offline_access = 64,
        #endregion

        #region  Page Permissions
        manage_pages = 128,
        #endregion

        #region Data Permissions
        email = 256,

        read_insights = 512,

        read_stream = 1024,

        read_mailbox = 2048,

        ads_management = 4096,

        xmpp_login = 8192,

        user_about_me = 16384,
        friends_activities = 32768,

        user_birthday = 65536,
        friends_birthday = 131072,

        user_education_history = 262144,
        friends_education_history = 524288,

        user_events = 1048576,
        friends_events = 2097152,

        user_groups = 4194304,
        friends_groups = 8388608,

        user_hometown = 16777216,
        friends_hometown = 33554432,

        user_interests = 67108864,
        friends_interests = 134217728,

        user_likes = 268435456,
        friends_likes = 536870912,

        user_location = 1073741824,
        friends_location = 2147483648,

        user_notes = 4294967296,
        friends_notes = 8589934592,

        user_online_presense = 17179869184,
        friends_online_presense = 34359738368,

        user_photo_video_tags = 68719476736,
        friends_photo_video_tags = 137438953472,

        user_photos = 274877906944,
        friends_photos = 549755813888,

        user_relationships = 1099511627776,
        friends_relationships = 2199023255552,

        user_religion_politics = 4398046511104,
        friends_religion_politics = 8796093022208,

        user_status = 17592186044416,
        friends_status = 35184372088832,

        user_videos = 70368744177664,
        friends_videos = 140737488355328,

        user_website = 281474976710656,
        friends_website = 562949953421312,

        user_work_history = 1125899906842624,
        friends_work_history = 2251799813685248,

        read_friendslists = 4503599627370496,

        read_requests = 9007199254740992

        #endregion
        
    }
}