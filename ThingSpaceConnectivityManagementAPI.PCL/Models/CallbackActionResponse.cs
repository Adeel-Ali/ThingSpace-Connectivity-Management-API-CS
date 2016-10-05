/*
 * ThingSpaceConnectivityManagementAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 10/05/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ThingSpaceConnectivityManagementAPI.PCL;

namespace ThingSpaceConnectivityManagementAPI.PCL.Models
{
    public class CallbackActionResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string accountName;
        private string serviceName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName 
        { 
            get 
            {
                return this.accountName; 
            } 
            set 
            {
                this.accountName = value;
                onPropertyChanged("AccountName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName 
        { 
            get 
            {
                return this.serviceName; 
            } 
            set 
            {
                this.serviceName = value;
                onPropertyChanged("ServiceName");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 