﻿namespace BrowseraConnector
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// The configuration for a site login.
    /// </summary>
    [Serializable]
    public class SiteLoginConfiguration
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a website login or basicAuth authentication.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a website login; or if <c>false</c> a basicAuth authentication.
        /// </value>
        [XmlElement("website_login")]
        public bool IsWebsiteLogin { get; set; }

        /// <summary>
        /// Gets or sets the login page URL.
        /// </summary>
        /// <value>
        /// The login page URL.
        /// </value>
        [XmlElement("login_page_url")]
        public string LoginPageUrl { get; set; }

        /// <summary>
        /// Gets or sets the user name input field's html id.
        /// </summary>
        /// <value>
        /// The user name input id.
        /// </value>
        [XmlElement("user_name_input_id")]
        public string UserNameInputId { get; set; }

        /// <summary>
        /// Gets or sets the password field's input id.
        /// </summary>
        /// <value>
        /// The password input id.
        /// </value>
        [XmlElement("password_input_id")]
        public string PasswordInputId { get; set; }
    }
}