//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.manager {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IVersionManagerBase {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getVersion();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getVersionN();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getVersionAsInt();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isLastRunVersionChanged();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IVersionManagerBase_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.manager.IVersionManagerBase))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.manager.IVersionManagerBase))]
    internal sealed partial class @__IVersionManagerBase : global::java.lang.Object, global::net.sf.robocode.manager.IVersionManagerBase {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getVersion0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getVersionN1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getVersionAsInt2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isLastRunVersionChanged3;
        
        private @__IVersionManagerBase(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass = @__class;
            global::net.sf.robocode.manager.@__IVersionManagerBase._getVersion0 = @__env.GetMethodID(global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass, "getVersion", "()Ljava/lang/String;");
            global::net.sf.robocode.manager.@__IVersionManagerBase._getVersionN1 = @__env.GetMethodID(global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass, "getVersionN", "()Ljava/lang/String;");
            global::net.sf.robocode.manager.@__IVersionManagerBase._getVersionAsInt2 = @__env.GetMethodID(global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass, "getVersionAsInt", "()I");
            global::net.sf.robocode.manager.@__IVersionManagerBase._isLastRunVersionChanged3 = @__env.GetMethodID(global::net.sf.robocode.manager.@__IVersionManagerBase.staticClass, "isLastRunVersionChanged", "()Z");
        }
        
        public global::java.lang.String getVersion() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.manager.@__IVersionManagerBase._getVersion0));
        }
        
        public global::java.lang.String getVersionN() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.manager.@__IVersionManagerBase._getVersionN1));
        }
        
        public int getVersionAsInt() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::net.sf.robocode.manager.@__IVersionManagerBase._getVersionAsInt2)));
        }
        
        public bool isLastRunVersionChanged() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.manager.@__IVersionManagerBase._isLastRunVersionChanged3)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IVersionManagerBase);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVersion", "getVersion0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVersionN", "getVersionN1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getVersionAsInt", "getVersionAsInt2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isLastRunVersionChanged", "isLastRunVersionChanged3", "()Z"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getVersion0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.manager.IVersionManagerBase @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.manager.IVersionManagerBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getVersion());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getVersionN1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.manager.IVersionManagerBase @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.manager.IVersionManagerBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getVersionN());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getVersionAsInt2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::net.sf.robocode.manager.IVersionManagerBase @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.manager.IVersionManagerBase>(@__env, @__obj);
            @__return = ((int)(@__real.getVersionAsInt()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool isLastRunVersionChanged3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.manager.IVersionManagerBase @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.manager.IVersionManagerBase>(@__env, @__obj);
            @__return = ((bool)(@__real.isLastRunVersionChanged()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.manager.@__IVersionManagerBase(@__env);
            }
        }
    }
    #endregion
}
