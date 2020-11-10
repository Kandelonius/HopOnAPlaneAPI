package com.shanek.hoponaplane.exceptions;

public class ResourceNotFoundException extends RuntimeException {

    public ResourceNotFoundException(String message)
    {
        super("Error from a Hop on a Plane application " + message);
    }
}
