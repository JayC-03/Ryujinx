using Ryujinx.OsHle.Handles;
using Ryujinx.OsHle.Objects;

using static Ryujinx.OsHle.Objects.ObjHelper;

namespace Ryujinx.OsHle.Services
{
    static partial class Service
    {
        public static long HidCreateAppletResource(ServiceCtx Context)
        {
            HSharedMem HidHndData = Context.Ns.Os.Handles.GetData<HSharedMem>(Context.Ns.Os.HidHandle);

            MakeObject(Context, new HidIAppletResource(HidHndData));

            return 0;
        }

        public static long HidActivateTouchScreen(ServiceCtx Context)
        {
            long Unknown = Context.RequestData.ReadInt64();

            return 0;
        }

        public static long HidSetSupportedNpadStyleSet(ServiceCtx Context)
        {
            long Unknown0 = Context.RequestData.ReadInt64();
            long Unknown8 = Context.RequestData.ReadInt64();

            return 0;
        }

        public static long HidSetSupportedNpadIdType(ServiceCtx Context)
        {
            long Unknown = Context.RequestData.ReadInt64();

            return 0;
        }

        public static long HidActivateNpad(ServiceCtx Context)
        {
            long Unknown = Context.RequestData.ReadInt64();

            return 0;
        }

        public static long HidSetNpadJoyHoldType(ServiceCtx Context)
        {
            long Unknown0 = Context.RequestData.ReadInt64();
            long Unknown8 = Context.RequestData.ReadInt64();

            return 0;
        }
    }
}