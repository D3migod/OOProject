using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Form
{
    override protected float moveSpeed { get { return 2; } }
    override protected float rotateSpeed { get { return 2; } }
    override protected float jumpSpeed { get { return 2; } }
}
