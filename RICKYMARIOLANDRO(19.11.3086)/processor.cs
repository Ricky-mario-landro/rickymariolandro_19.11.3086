using System;
using System.Collections.Generic;
using System.Text;

//Ricky mario landro
//19.11.3086
//informatika 08

namespace TheSuperComputer
{
    class processor
    {
        private String series;
        private int core;
        private int cache;

        public processor()
        {

        }

        public void setSeries(String series)
        {
            this.series = series;
        }

        public String getSeries()
        {
            return this.series;
        }

        public void setCore(int core)
        {
            this.core = core;
        }

        public int getCore()
        {
            return this.core;
        }

        public void setCache(int cache)
        {
            this.cache = cache;
        }

        public int getCache()
        {
            return this.cache;
        }

        public override string ToString()
        {
            return $"Processor series:{this.series}; Processor core: {this.core} ; Processor cache:{this.cache}";
        }
    }
}

