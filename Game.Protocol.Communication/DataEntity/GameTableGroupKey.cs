namespace Game.Protocol.Communication.DataEntity
{
    using System;

    /// <summary>
    /// GameTableGroupKey
    /// </summary>
    public class GameTableGroupKey : IEquatable<GameTableGroupKey>
    {
        #region Property

        /// <summary>
        /// Gets or sets GameID
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Gets or sets TableGroupID
        /// </summary>
        public int TableGroupID { get; set; }

        #endregion Property

        #region Method

        /// <summary>
        /// Equals compare
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(GameTableGroupKey other)
        {
            return this.GameID == other.GameID &&
                this.TableGroupID == other.TableGroupID;
        }

        /// <summary>
        /// Equals compare
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var key = obj as GameTableGroupKey;
            if (key == null)
            {
                return false;
            }

            return this.Equals(key);
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            //long serial = ((long)this.GameID * 10000 + (long)this.TableGroupID) * 10000 + (long)this.TableID;
            long serial = ((long)this.GameID * 10000 + (long)this.TableGroupID);
            return serial.GetHashCode();
        }

        /// <summary>
        /// operator ==
        /// </summary>
        /// <param name="key1">key 1</param>
        /// <param name="key2">key 2</param>
        /// <returns>result</returns>
        public static bool operator ==(GameTableGroupKey key1, GameTableGroupKey key2)
        {
            if ((object)key1 == null || ((object)key2) == null)
            {
                return Object.Equals(key1, key2);
            }

            return key1.Equals(key2);
        }

        /// <summary>
        /// operator !=
        /// </summary>
        /// <param name="key1">key 1</param>
        /// <param name="key2">key 2</param>
        /// <returns>result</returns>
        public static bool operator !=(GameTableGroupKey key1, GameTableGroupKey key2)
        {
            return !(key1 == key2);
        }

        #endregion Method
    }
}
