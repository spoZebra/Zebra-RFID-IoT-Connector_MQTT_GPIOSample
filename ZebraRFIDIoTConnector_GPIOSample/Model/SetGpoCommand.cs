using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZebraRFIDIoTConnector_GPIOSample.Model
{

    /// <summary>
    /// Updates GPO port state
    /// </summary>
    [DataContract]
    public partial class SetGpoCommand : IEquatable<SetGpoCommand>
    {
        /// <summary>
        /// The GPO port ID
        /// </summary>
        /// <value>The GPO port ID</value>
        [Required]

        [Range(1, 4)]
        [DataMember(Name = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// The GPO state signal to send
        /// </summary>
        /// <value>The GPO state signal to send</value>
        [Required]

        [DataMember(Name = "state")]
        public bool? State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetGpoCommand {\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SetGpoCommand)obj);
        }

        /// <summary>
        /// Returns true if SetGpoCommand instances are equal
        /// </summary>
        /// <param name="other">Instance of SetGpoCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetGpoCommand other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) &&
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(SetGpoCommand left, SetGpoCommand right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SetGpoCommand left, SetGpoCommand right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
