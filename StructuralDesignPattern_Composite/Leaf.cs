﻿namespace StructuralDesignPattern_Composite
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.
    public class Leaf : Component
    {
        public override string Operation() => "Leaf";

        public override bool IsComposite() => false;
    }
}
