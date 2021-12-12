import React from 'react'
import { render,  fireEvent, act } from '@testing-library/react'
import Job from './Job'

describe('RegisterForm', () => {

  const renderJob = () => {
    
    return render(<Job />)
  }

  it('should render job list', () => {
    const { getByTestId } = renderJob()
    expect(getByTestId('job-list')).toBeTruthy()
  })

})


