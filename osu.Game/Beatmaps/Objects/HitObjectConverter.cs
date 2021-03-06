﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;

namespace osu.Game.Beatmaps.Objects
{
    public abstract class HitObjectConverter<T>
        where T : HitObject
    {
        public abstract List<T> Convert(List<HitObject> input);
    }
}
