package com.shanek.hoponaplane.repositories;

import com.shanek.hoponaplane.models.User;
import org.springframework.data.repository.CrudRepository;

public interface UserRepository extends CrudRepository<User, Long> {
}
