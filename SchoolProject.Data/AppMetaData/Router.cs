﻿namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string SingleRoute = "/{id}";
        public const string root = "Api";

        public const string version = "V1";

        public const string Rule = root + "/" + version + "/";


        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + SingleRoute;
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";

            public const string Delete = Prefix + "/{id}";
            public const string Paginated = Prefix + "/Paginated";


        }

        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "/id";
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";

            public const string Delete = Prefix + "/{id}";
            public const string Paginated = Prefix + "/Paginated";


        }

        public static class ApplicationUserRouting
        {
            public const string Prefix = Rule + "User";
            public const string GetById = Prefix + "/id";
            public const string Create = Prefix + "/Create";
            public const string Delete = Prefix + "/{id}";
            public const string ChangePassword = Prefix + "/Change-Password";

            public const string Paginated = Prefix + "/Paginated";

            public const string Edit = Prefix + "/Edit";

        }

        public static class Authentication
        {
            public const string Prefix = Rule + "Authentication";
            public const string SignIn = Prefix + "/SignIn";


        }


    }
}
