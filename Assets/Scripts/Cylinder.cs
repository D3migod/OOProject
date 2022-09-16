using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Form
{
    override protected float moveSpeed { get { return 3; } }
    override protected float rotateSpeed { get { return 3; } }
    override protected float jumpSpeed { get { return 3; } }
}
