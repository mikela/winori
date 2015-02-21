namespace Winori.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }

        [System.Configuration.UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public System.Collections.Generic.ISet<System.Windows.Forms.Keys> ulComboSetting
        {
            get
            {
                return ((System.Collections.Generic.ISet<System.Windows.Forms.Keys>)(this["ulComboSetting"]));
            }
            set
            {
                this["ulComboSetting"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public System.Collections.Generic.ISet<System.Windows.Forms.Keys> urComboSetting
        {
            get
            {
                return ((System.Collections.Generic.ISet<System.Windows.Forms.Keys>)(this["urComboSetting"]));
            }
            set
            {
                this["urComboSetting"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public System.Collections.Generic.ISet<System.Windows.Forms.Keys> dlComboSetting
        {
            get
            {
                return ((System.Collections.Generic.ISet<System.Windows.Forms.Keys>)(this["dlComboSetting"]));
            }
            set
            {
                this["dlComboSetting"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Configuration.SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public System.Collections.Generic.ISet<System.Windows.Forms.Keys> drComboSetting
        {
            get
            {
                return ((System.Collections.Generic.ISet<System.Windows.Forms.Keys>)(this["drComboSetting"]));
            }
            set
            {
                this["drComboSetting"] = value;
            }
        }
    }
}
