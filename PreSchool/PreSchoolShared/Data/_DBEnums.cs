﻿using PreSchoolShared.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PreSchoolShared.Data
{
    public enum EntityStatus
    {
        [Display(Name = "Không rõ"), StatusCss("default")]
        None,
        [Display(Name = "Hoạt động"), StatusCss("success")]
        Enabled,
        [Display(Name = "Tạm ngưng"), StatusCss("warning")]
        Disabled,
        [Display(Name = "Hết hạn"), StatusCss("danger")]
        Expiried,
    }

    public enum UserMode
    {
        None,
        Locked,
        Unlocked,
        Unlocking,
    }

    public enum UserAction
    {
        None,
        Register,
        ChangePass,
        ChangeEmail,
        VerifyEmail,
        ChangePhone,
        VerifyPhone,
        RequestOTP,
        ExternalAddLogin,
        ExternalRemoveLogin,
        ExternalSetPassword,
        UpdateProfile,
        UpdateAllInfo,
        LockAccount,
        UnlockAccount,
        UnlockAccountDone,
        ForgotPassword,
        ResetPassByEmail,
        ResetPassByPhone,
        GameInstall,
        GamePushToken,
        GameFirstLogin,
        GameGoalArchived,
    }

    public enum ThreadStatus
    {
        [Display(Name = "Chưa đọc"), StatusCss("warning")]
        Pending,

        [Display(Name = "Đã đọc"), StatusCss("info")]
        Read,

        [Display(Name = "Đã trả lời"), StatusCss("success")]
        Replied,

        [Display(Name = "Đã xử lý"), StatusCss("default")]
        Processed,
    }

    public enum TaxoType
    {
        PostCat,
        PostTag,
    }

    public enum PostFormat
    {
        [Display(Name = "Thông thường")]
        Standard,

        [Display(Name = "Thư viện hình")]
        Gallery,

        [Display(Name = "Bài Video")]
        Video,
    }

    public enum PostStatus
    {
        [Display(Name = "Tin đã khóa")]
        Suspended = -1,

        [Display(Name = "Chờ đăng tin")]
        Pending,

        [Display(Name = "Tin thường")]
        Normal,

        [Display(Name = "Đặc biệt")]
        Special,
    }
    public enum UserPosition
    {
        [Display(Name = "Người ngoài")]
        None = -1,
        [Display(Name = "Học sinh")]
        Student = 0,
        [Display(Name = "Phụ huynh")]
        Parents,
        [Display(Name = "Giáo viên")]
        Teacher,
        [Display(Name = "Hiệu trưởng")]
        principal,
    }
    public enum DaySchedule
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
    }
}
