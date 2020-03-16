using System;
using System.Collections.Generic;
using System.Text;
//Ricky mario landro
//19.11.3086
//informatika 08

namespace TheSuperComputer
{
    class monitor
    {
        //resolution, supporthdmi, size
        private String resolution;
        private Boolean supportHdmi;
        private double size;

        public monitor(String resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }

        private String getResolution()
        {
            return this.resolution;
        }

        private Boolean isSupportHdmi()
        {
            return this.supportHdmi;
        }

        private double getSize()
        {
            return this.size;
        }

        public override string ToString()
        {
            return $"Monitor resolution: {resolution} ; Monitor support hdmi : {supportHdmi}; Monitor dimensi : {size} inch ";
        }
    }
}
    

