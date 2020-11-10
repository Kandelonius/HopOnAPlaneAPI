package com.shanek.hoponaplane.services;

import com.shanek.hoponaplane.exceptions.ResourceNotFoundException;
import com.shanek.hoponaplane.models.User;
import com.shanek.hoponaplane.repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;

/**
 * Implements UserService Interface
 */
@Transactional
@Service(value = "userService")
public class UserServiceImpl
    implements UserService {

    /**
     * Connects this service to the User table.
     */
    @Autowired
    private UserRepository userrepos;

    public User findUserById(long id) throws
                                      ResourceNotFoundException
    {
        return userrepos.findById(id)
            .orElseThrow(() -> new ResourceNotFoundException("User id " + id + " not found!"));
    }

    @org.springframework.transaction.annotation.Transactional
    @Override
    public void delete(long id)
    {
        userrepos.findById(id)
            .orElseThrow(() -> new ResourceNotFoundException("User id " + id + " not found!"));
        userrepos.deleteById(id);
    }

    @org.springframework.transaction.annotation.Transactional
    @Override
    public User save(User user)
    {
        User newUser = new User();

        if (user.getUserid() != 0)
        {
            userrepos.findById(user.getUserid())
                .orElseThrow(() -> new ResourceNotFoundException("User id " + user.getUserid() + " not found!"));
            newUser.setUserid(user.getUserid());
        }
        return userrepos.save(newUser);
    }

    @org.springframework.transaction.annotation.Transactional
    @Override
    public User update(
        User user,
        long id) {
        User currentUser = findUserById(id);

        if (user.getUsername() != null) {
            currentUser.setUsername(user.getUsername()
                .toLowerCase());
        }

        if (user.getPassword() != null) {
            currentUser.setPasswordNoEncrypt(user.getPassword());
        }
        return userrepos.save(currentUser);
    }
}
