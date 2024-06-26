﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLife.GlobalConstants
{
    public static class DataConstants
    {

        /// <summary>
        /// Date format
        /// </summary>
        public const string DateFormat = "dd/MM/yyyy HH:mm";

        /// <summary>
        /// Title minimum length
        /// </summary>
        public const int TitleMinLength = 3;

        /// <summary>
        /// Title maximum length
        /// </summary>
        public const int TitleMaxLength = 50;

        /// <summary>
        /// Description minimum length
        /// </summary>
        public const int DescriptionMinLength = 10;

        /// <summary>
        /// Description maximum length
        /// </summary>
        public const int DescriptionMaxLength = 500;

        /// <summary>
        /// Name minimum length
        /// </summary>
        public const int NameMinLength = 2;

        /// <summary>
        /// Name maximum length
        /// </summary>
        public const int NameMaxLength = 50;

        /// <summary>
        /// City minimum length
        /// </summary>
        public const int CityMinLength = 3;

        /// <summary>
        /// City maximum length
        /// </summary>
        public const int CityMaxLength = 60;

        public static class TrainingProgram
        {
            /// <summary>
            /// Training program's minimum duration in days
            /// </summary>
            public const int DurationMinDays = 1;

            /// <summary>
            /// Training program's maximum duration in days
            /// </summary>
            public const int DurationMaxDays = 365;
        }

        public static class Event
        {
            /// <summary>
            /// Event's address minimum length
            /// </summary>
            public const int AddressMinLength = 10;

            /// <summary>
            /// Event's address maximum length
            /// </summary>
            public const int AddressMaxLength = 150;
        }                

        public static class Product
        {
            /// <summary>
            /// Product's minimum price
            /// </summary>
            public const int MinPrice = 0;

            /// <summary>
            /// Product's maximum price
            /// </summary>
            public const int MaxPrice = 1000000;

            /// <summary>
            /// Product's minimum available stock
            /// </summary>
            public const int MinStock = 1;

            /// <summary>
            /// Product's maximum available stock
            /// </summary>
            public const int MaxStock = 1000000;
        }

    }
}
