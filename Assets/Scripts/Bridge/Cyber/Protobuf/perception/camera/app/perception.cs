// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: perception.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.app
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PluginParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PluginParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string root_dir
        {
            get { return __pbn__root_dir ?? ""; }
            set { __pbn__root_dir = value; }
        }
        public bool ShouldSerializeroot_dir()
        {
            return __pbn__root_dir != null;
        }
        public void Resetroot_dir()
        {
            __pbn__root_dir = null;
        }
        private string __pbn__root_dir;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string config_file
        {
            get { return __pbn__config_file ?? ""; }
            set { __pbn__config_file = value; }
        }
        public bool ShouldSerializeconfig_file()
        {
            return __pbn__config_file != null;
        }
        public void Resetconfig_file()
        {
            __pbn__config_file = null;
        }
        private string __pbn__config_file;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DetectorParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DetectorParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string camera_name
        {
            get { return __pbn__camera_name ?? ""; }
            set { __pbn__camera_name = value; }
        }
        public bool ShouldSerializecamera_name()
        {
            return __pbn__camera_name != null;
        }
        public void Resetcamera_name()
        {
            __pbn__camera_name = null;
        }
        private string __pbn__camera_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrackerParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrackerParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TransformerParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TransformerParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PostprocessorParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PostprocessorParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FeatureParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FeatureParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DebugParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string detection_out_dir
        {
            get { return __pbn__detection_out_dir ?? ""; }
            set { __pbn__detection_out_dir = value; }
        }
        public bool ShouldSerializedetection_out_dir()
        {
            return __pbn__detection_out_dir != null;
        }
        public void Resetdetection_out_dir()
        {
            __pbn__detection_out_dir = null;
        }
        private string __pbn__detection_out_dir;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tracked_detection_out_dir
        {
            get { return __pbn__tracked_detection_out_dir ?? ""; }
            set { __pbn__tracked_detection_out_dir = value; }
        }
        public bool ShouldSerializetracked_detection_out_dir()
        {
            return __pbn__tracked_detection_out_dir != null;
        }
        public void Resettracked_detection_out_dir()
        {
            __pbn__tracked_detection_out_dir = null;
        }
        private string __pbn__tracked_detection_out_dir;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string track_out_file
        {
            get { return __pbn__track_out_file ?? ""; }
            set { __pbn__track_out_file = value; }
        }
        public bool ShouldSerializetrack_out_file()
        {
            return __pbn__track_out_file != null;
        }
        public void Resettrack_out_file()
        {
            __pbn__track_out_file = null;
        }
        private string __pbn__track_out_file;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string detect_feature_dir
        {
            get { return __pbn__detect_feature_dir ?? ""; }
            set { __pbn__detect_feature_dir = value; }
        }
        public bool ShouldSerializedetect_feature_dir()
        {
            return __pbn__detect_feature_dir != null;
        }
        public void Resetdetect_feature_dir()
        {
            __pbn__detect_feature_dir = null;
        }
        private string __pbn__detect_feature_dir;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_out_dir
        {
            get { return __pbn__lane_out_dir ?? ""; }
            set { __pbn__lane_out_dir = value; }
        }
        public bool ShouldSerializelane_out_dir()
        {
            return __pbn__lane_out_dir != null;
        }
        public void Resetlane_out_dir()
        {
            __pbn__lane_out_dir = null;
        }
        private string __pbn__lane_out_dir;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string camera2world_out_file
        {
            get { return __pbn__camera2world_out_file ?? ""; }
            set { __pbn__camera2world_out_file = value; }
        }
        public bool ShouldSerializecamera2world_out_file()
        {
            return __pbn__camera2world_out_file != null;
        }
        public void Resetcamera2world_out_file()
        {
            __pbn__camera2world_out_file = null;
        }
        private string __pbn__camera2world_out_file;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string calibration_out_dir
        {
            get { return __pbn__calibration_out_dir ?? ""; }
            set { __pbn__calibration_out_dir = value; }
        }
        public bool ShouldSerializecalibration_out_dir()
        {
            return __pbn__calibration_out_dir != null;
        }
        public void Resetcalibration_out_dir()
        {
            __pbn__calibration_out_dir = null;
        }
        private string __pbn__calibration_out_dir;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LanePerceptionParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LanePerceptionParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public DetectorParam lane_detector_param { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public PluginParam lane_postprocessor_param { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public PluginParam lane_tracker_param { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public int gpu_id
        {
            get { return __pbn__gpu_id.GetValueOrDefault(); }
            set { __pbn__gpu_id = value; }
        }
        public bool ShouldSerializegpu_id()
        {
            return __pbn__gpu_id != null;
        }
        public void Resetgpu_id()
        {
            __pbn__gpu_id = null;
        }
        private int? __pbn__gpu_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CalibrationServiceParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CalibrationServiceParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string calibrator_method
        {
            get { return __pbn__calibrator_method ?? ""; }
            set { __pbn__calibrator_method = value; }
        }
        public bool ShouldSerializecalibrator_method()
        {
            return __pbn__calibrator_method != null;
        }
        public void Resetcalibrator_method()
        {
            __pbn__calibrator_method = null;
        }
        private string __pbn__calibrator_method;

        [global::ProtoBuf.ProtoMember(3)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ObjectTemplateParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ObjectTemplateParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PluginParam plugin_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PerceptionParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PerceptionParam()
        {
            detector_param = new global::System.Collections.Generic.List<DetectorParam>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<DetectorParam> detector_param { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        public TrackerParam tracker_param { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public TransformerParam transformer_param { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public PostprocessorParam postprocessor_param { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public int gpu_id
        {
            get { return __pbn__gpu_id.GetValueOrDefault(); }
            set { __pbn__gpu_id = value; }
        }
        public bool ShouldSerializegpu_id()
        {
            return __pbn__gpu_id != null;
        }
        public void Resetgpu_id()
        {
            __pbn__gpu_id = null;
        }
        private int? __pbn__gpu_id;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string camera_intrinsics
        {
            get { return __pbn__camera_intrinsics ?? ""; }
            set { __pbn__camera_intrinsics = value; }
        }
        public bool ShouldSerializecamera_intrinsics()
        {
            return __pbn__camera_intrinsics != null;
        }
        public void Resetcamera_intrinsics()
        {
            __pbn__camera_intrinsics = null;
        }
        private string __pbn__camera_intrinsics;

        [global::ProtoBuf.ProtoMember(7)]
        public FeatureParam feature_param { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public LanePerceptionParam lane_param { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public CalibrationServiceParam calibration_service_param { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public DebugParam debug_param { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public ObjectTemplateParam object_template_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrafficLightParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrafficLightParam()
        {
            detector_param = new global::System.Collections.Generic.List<DetectorParam>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<DetectorParam> detector_param { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        public TrackerParam tracker_param { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int gpu_id
        {
            get { return __pbn__gpu_id.GetValueOrDefault(); }
            set { __pbn__gpu_id = value; }
        }
        public bool ShouldSerializegpu_id()
        {
            return __pbn__gpu_id != null;
        }
        public void Resetgpu_id()
        {
            __pbn__gpu_id = null;
        }
        private int? __pbn__gpu_id;

    }

}

#pragma warning restore 0612, 1591, 3021