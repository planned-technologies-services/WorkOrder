namespace Planned.Handlers
{
    
    
    public partial class BlobFactoryConfig : BlobFactory
    {
        
        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("WOCompletionSignature", "\"dbo\".\"WO\"", "\"CompletionSignature\"", new string[] {
                        "\"woId\""}, "Wo Completion Signature", "Wo", "CompletionSignature");
            RegisterHandler("WoItemAttachmentHandler", "\"dbo\".\"woItemAttachment\"", "\"Attachment\"", new string[] {
                        "\"woItemAttachmentId\""}, "Wo Item Attachment Attachment", "WoItemAttachment", "Attachment");
        }
    }
}
