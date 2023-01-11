using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace ServiceLayer {
    /// <summary>
    /// Class <c>UserSystem</c> holds current user data and manages user interactions.
    /// </summary>
    public static class UserSystem {
        private static tb_users currentUser;

        /// <returns>Entity that represents current logged in user<br />null if not logged in</returns>
        public static tb_users CurrentUser { get => currentUser; private set => currentUser = value; }

        private static bool loggedIn = false;

        /// <returns>Whether current user logged in or not</returns>
        public static bool LoggedIn {
            get => loggedIn;
        }

        /// <returns>Whether current user has admin privileges or not<br />false if not logged in</returns>
        public static bool IsAdmin {
            get => LoggedIn && IsUserAdmin(CurrentUser);
        }

        private static string[] admins = new string[] { "Admin" };

        public static bool IsUserAdmin(tb_users user) {
           return admins.Contains(user.tb_groups.groupName);
        }
        /// <summary>
        /// This method loads user data from application settings.<br />
        /// You can reach loaded user data from
        /// <c>UserSystem.CurrentUser</c>
        /// </summary>
        public static void LoadUser() {
            string username = Properties.UserSettings.Default.username;
            string password = Properties.UserSettings.Default.password;
            Debug.WriteLine(username+" "+password);
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) return;

            Login(username, password);
        }

        /// <summary>
        /// This method saves user data to applications settings.<br />
        /// Method takes user data from
        /// <c>UserSystem.CurrentUser</c>
        /// </summary>
        private static void SaveUser() {
            Properties.UserSettings us = Properties.UserSettings.Default;
            if (LoggedIn) {
                us.username = CurrentUser.username;
                us.password = CurrentUser.password;
            } else {
                us.username = "";
                us.password = "";
            }
            us.Save();
        }

        /// <summary>
        /// This method tries to login to account with given parameters.<br />
        /// Loads user data to <c>UserSystem.CurrentUser</c> if the process succeed.
        /// </summary>
        /// <returns>Result of the login process</returns>
        /// <param name="username">Username to perform login process</param>
        /// <param name="password">Password to perform login process</param>
        public static bool Login(string username, string password) {
            surmanEntities entities = new surmanEntities();
            tb_users result;
#pragma warning disable CS0168 // Variable is declared but never used
            try { 
                result = entities.tb_users.First(row => row.username == username && row.password == password);
            }catch(Exception e) {
                return false;
            }
#pragma warning restore CS0168 // Variable is declared but never used
            _Login(result);
            return true;
        }

        /// <summary>
        /// This method tries to register user with given parameters.<br />
        /// Loads user data to <c>UserSystem.CurrentUser</c> if the process succeed.
        /// </summary>
        /// <returns>Result of the register process</returns>
        /// <param name="username">Username to perform the register process</param>
        /// <param name="password">Password to perform the register process</param>
        public static bool Register(string username, string password) {
            surmanEntities entities = new surmanEntities();
            tb_users user = new tb_users();
            user.groupId = entities.tb_groups.First(row => row.groupName == "User").groupId;
            user.username = username;
            user.password = password;
            user = entities.tb_users.Add(user);
#pragma warning disable CS0168 // Variable is declared but never used
            try {
                entities.SaveChanges();
            }
            catch (Exception e) {

                return false;
            }
#pragma warning restore CS0168 // Variable is declared but never used
            _Login(user);
            return true;
        }

        /// <summary>
        /// This method logs out the user.
        /// </summary>
        public static void Logout() {
            CurrentUser = null;
            loggedIn = false;
            SaveUser();
        }

        private static void _Login(tb_users user) {
            CurrentUser = user;
            loggedIn = true;
            SaveUser();
        }
    }
}
