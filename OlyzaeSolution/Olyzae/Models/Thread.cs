//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NihonUnisys.Olyzae.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// メッセージのやり取りを通じたコミュニケーションに使用するスレッドの基底クラス。
    /// </summary>
    public partial class Thread
    {
        public Thread()
        {
            this.Message = new HashSet<Message>();
            this.ReceivedUsers = new HashSet<ParticipantUserThread>();
        }

        public int ID { get; set; }

        [Required]
        public string ThreadName { get; set; }

        /// <summary>
        /// このスレッドが公開され、メッセージの投稿が可能になっている期間。
        /// 期限のないスレッドについてはこのプロパティは使用しません。
        /// </summary>
        public virtual Duration Duration { get; set; }

        public virtual ICollection<Message> Message { get; set; }

        /// <summary>
        /// スレッドの読み書きが可能な参加者を限定するための関連プロパティ。
        /// </summary>
        /// <remarks>
        /// 企業から参加者へのお知らせとして使用するProjectThreadクラスで使用します。
        /// </remarks>
        public virtual ICollection<ParticipantUserThread> ReceivedUsers { get; set; }
    }
}
