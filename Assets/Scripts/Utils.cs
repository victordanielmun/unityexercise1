using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Utils {
  public static void CopyTransform (Transform copy, Transform original) {
    copy.position = original.position;
    copy.rotation = original.rotation;
    copy.localScale = original.localScale;
  }
}